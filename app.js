const form = document.getElementById("hostForm");
const submitBtn = document.getElementById("submitBtn");
const statusEl = document.getElementById("status");

function setBusy(isBusy, msg = "") {
  submitBtn.disabled = isBusy;
  submitBtn.textContent = isBusy ? "Submitting..." : "Submit";
  statusEl.textContent = msg;
}

form.addEventListener("submit", async (e) => {
  e.preventDefault();
  setBusy(true, "Sending...");

  // Basic front-end validation
  const required = ["fullName", "email", "city", "country"];
  for (const key of required) {
    const el = form.elements[key];
    if (!el || !el.value.trim()) {
      setBusy(false, `Please fill ${key}`);
      el && el.focus();
      return;
    }
  }

  // Honeypot trap: if filled, treat as spam
  if (form.elements["website"].value) {
    setBusy(false, "Thanks!");
    return;
  }

  try {
    // Use URLSearchParams to avoid CORS preflight
    const payload = new URLSearchParams();
    [...new FormData(form).entries()].forEach(([k, v]) => payload.append(k, v));

    const res = await fetch(GAS_WEB_APP_URL, {
      method: "POST",
      body: payload
      // No headers => browser will set application/x-www-form-urlencoded
      // No preflight = works smoothly with Apps Script
    });

    // Apps Script often returns text; try to parse JSON, fallback to text
    const raw = await res.text();
    let data;
    try { data = JSON.parse(raw); } catch { data = { status: "unknown", body: raw }; }

    if (res.ok && (data.status === "ok" || data.result === "ok")) {
      setBusy(false, "Submitted! We’ll reach out soon.");
      form.reset();
    } else {
      setBusy(false, "Submission failed. Please try again.");
      console.error("Backend replied:", raw);
    }
  } catch (err) {
    console.error(err);
    setBusy(false, "Network error. Check your connection and try again.");
  }
});
