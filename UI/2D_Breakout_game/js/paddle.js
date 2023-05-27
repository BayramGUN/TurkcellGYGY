import { 
    context,
    height,
    paddleHeight,
    paddleWidth
} from "./exports.js";



export const drawPaddle = (paddleX) => {
    context.beginPath();
    context.rect(paddleX, height-paddleHeight, paddleWidth, paddleHeight);
    context.fillStyle = "#0095DD";
    context.fill();
    context.closePath();
}