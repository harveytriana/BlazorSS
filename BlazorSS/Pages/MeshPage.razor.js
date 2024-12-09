'use strict';

export function drawMesh() {
    // elements
    const canvas = document.getElementById('canvas');
    const ctx = canvas.getContext('2d');
    const xy = document.getElementById('xyCanvas');
    const MESH_COLOR = 'LightGray';
    const R = 0.5;

    ctx.translate(R, R) // try a line of one pixel
    ctx.strokeStyle = MESH_COLOR;

    const drawLine = (x0, y0, x1, y1) => {
        ctx.moveTo(x0, y0);
        ctx.lineTo(x1, y1);
    }

    let w = canvas.clientWidth;
    let h = canvas.clientHeight;
    let mx = w / 20.0;
    let my = h / 20.0;

    for (let x = 0; x < w; x += mx) {
        drawLine(x, 0, x, h);
    }
    // perfect close
    drawLine(w - 1, 0, w - 1, h);

    for (let y = 0; y < h; y += my) {
        drawLine(0, y, w, y);
    }
    // perfect close
    drawLine(0, h - 1, w, h - 1);

    ctx.stroke();

    // coordinates
    canvas.addEventListener("mousemove", function (e) {
        let r = canvas.getBoundingClientRect();
        let x = Math.round(e.clientX - r.left);
        let y = Math.round(e.clientY - r.top);
        xy.textContent = `X: ${x} Y: ${y}`;
    });

}