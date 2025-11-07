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
