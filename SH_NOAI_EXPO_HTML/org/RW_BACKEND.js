const _GS_URL  = 'https://script.google.com/macros/s/AKfycbwmJnPLvUNl1I55qloWXyvZ3GCHhRb_P-ZweHxpJfhFGKVjQ7T-qx_m-eUK-wVjFXD-/exec';

const _GS_STUDENT_KEY = 'bronnenlab_student';
const _GS_CODE_KEY    = 'bronnenlab_code';
const _GS_PIN_KEY     = 'bronnenlab_pin';

const student = "alexander rogiers".trim();
const code = "GEO5ste2026".trim();
const pin = "000000".trim();

async function _gsPost(data){
  const r = await Promise.race([
    fetch(_GS_URL,{method:'POST',body:JSON.stringify(data)}),
    new Promise((_,rej)=>setTimeout(()=>rej(new Error('Time-out')),20000))
  ]);
  return r.json();
}


async function READ(){
    console.log("READ");
    console.log("READ student",student);
    console.log("READ code",code);
    console.log("READ pin",pin);
    try{
        const res = await _gsPost({
            action:'save', student, code, pin,
            xp: 10,
            streak: 1,
            scores: 1,
            answers: 1,
            go: 1,
            open: {}
        });
        if (res.ok && res.data){
            console.log("READ res.ok",res.ok + res.data);
        }
        else{
            console.error("READ res.error",res.error);
        }
        console.log("READ res",res);
    } catch (e) {
        console.error("(READ) error:", e);
    }
}