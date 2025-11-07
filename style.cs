:root {
  --bg:#0f172a; --card:#111827; --muted:#94a3b8; --text:#e5e7eb;
  --accent:#8b5cf6; --accent2:#22d3ee; --border:#1f2937; --radius:14px;
}
*{box-sizing:border-box} body{margin:0; background:#0b1220; color:var(--text); font:16px/1.5 system-ui,Segoe UI,Inter,Arial}
.container{max-width:760px; margin:40px auto; padding:24px; background:var(--card); border:1px solid var(--border); border-radius:var(--radius)}
h1{margin:0 0 6px} .muted{color:var(--muted); margin:0 0 22px}
form{display:grid; gap:16px}
.row{display:grid; grid-template-columns:1fr 1fr; gap:12px}
@media (max-width:720px){ .row{grid-template-columns:1fr} }
label{display:grid; gap:6px; font-weight:600}
input, select{padding:12px; background:#0c1527; border:1px solid var(--border); color:var(--text); border-radius:10px; outline:none}
input:focus,select:focus{border-color:var(--accent)}
.group{padding:12px; border:1px dashed var(--border); border-radius:12px}
legend{padding:0 6px; color:var(--muted)}
.chk{display:flex; align-items:center; gap:10px; font-weight:500}
.actions{display:flex; align-items:center; gap:12px}
button{padding:12px 16px; border-radius:10px; border:0; background:linear-gradient(135deg,var(--accent),var(--accent2)); color:white; font-weight:700; cursor:pointer}
button:disabled{opacity:.6; cursor:not-allowed}
#status{min-height:1em; color:var(--muted)}
.hp{position:absolute; left:-9999px; top:-9999px}
/* ========== Theme ==========\ */
:root{
  --bg:#0f172a; --card:#111827; --muted:#94a3b8; --text:#e5e7eb;
  --accent:#8b5cf6; --accent2:#22d3ee; --border:#1f2937; --radius:14px;
}

/* ========== Base ==========\ */
*{box-sizing:border-box}
html,body{height:100%}
body{
  margin:0;
  background:#0b1220;
  color:var(--text);
  font:16px/1.5 system-ui, Segoe UI, Inter, Arial, sans-serif;
  -webkit-text-size-adjust:100%; /* avoid iOS zoom jitter */
}

/* ========== Layout ==========\ */
.container{
  max-width:760px;
  margin:40px auto;
  padding:24px;
  background:var(--card);
  border:1px solid var(--border);
  border-radius:var(--radius);
}
@media (max-width:768px){
  .container{margin:16px; padding:16px}
}

h1{margin:0 0 6px}
.muted{color:var(--muted); margin:0 0 22px}

/* Form grid */
form{display:grid; gap:16px}

/* Two-column rows by default, collapse to one column on small screens */
.row{
  display:grid;
  grid-template-columns:1fr 1fr;
  gap:16px; /* a bit more breathing room */
}
@media (max-width:768px){
  .row{grid-template-columns:1fr}
}

/* Labels wrap their controls vertically */
label{
  display:grid;
  gap:8px;
  font-weight:600;
  width:100%;
  min-width:0; /* prevents overflowing in CSS grid */
}

/* Inputs / selects */
input, select{
  width:100%;
  min-width:0; /* allow shrinking inside grid cells */
  padding:14px 12px;
  background:#0c1527;
  border:1px solid var(--border);
  color:var(--text);
  border-radius:10px;
  outline:none;
  font-size:16px; /* avoid iOS zoom on focus */
  line-height:1.4;
}

/* Better focus accessibility */
input:focus, select:focus{
  border-color:var(--accent);
  box-shadow:0 0 0 3px color-mix(in srgb, var(--accent) 35%, transparent);
}

/* Hover state (desktop) */
@media (hover:hover){
  input:hover, select:hover{border-color:#2b364b}
}

/* Field groups / fieldsets */
.group{
  padding:12px;
  border:1px dashed var(--border);
  border-radius:12px;
}
legend{
  padding:0 6px;
  color:var(--muted);
  font-weight:600;
}

/* Checkbox rows */
.chk{
  display:flex;
  align-items:center;
  gap:10px;
  font-weight:500;
}

/* Bigger, easier-to-tap checkboxes on mobile */
.chk input[type="checkbox"]{
  width:20px; height:20px;
}

/* Actions row */
.actions{
  display:flex;
  align-items:center;
  gap:12px;
  flex-wrap:wrap;
}

/* Buttons */
button{
  padding:12px 16px;
  border-radius:10px;
  border:0;
  background:linear-gradient(135deg,var(--accent),var(--accent2));
  color:#fff;
  font-weight:700;
  cursor:pointer;
}
button:disabled{opacity:.6; cursor:not-allowed}

/* Status text */
#status{min-hei
