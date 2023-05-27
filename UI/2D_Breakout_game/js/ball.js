import { 
    context,
    ballRadius,
} from "./exports.js";


// drawng ball:
export const drawBall = (x, y) => {
    context.beginPath();
    context.arc(x, y, ballRadius, 0, Math.PI * 2);
    context.fillStyle = "#0095DD";
    context.fill();
    context.closePath();
}

/* export const bounceBall = (x, y, dx, dy) => {
    // ball bouncing from the edge of canvas:
    if( x + dx > width - ballRadius || x + dx < ballRadius) {
        dx = -dx;
    }
    if( y + dy > height - ballRadius || y + dy < ballRadius) {
        dy = -dy;
    }
    
    
    x += dx;
    y += dy;
} */


//moving ball on canvas:
