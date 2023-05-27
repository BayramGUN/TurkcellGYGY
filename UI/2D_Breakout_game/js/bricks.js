import { 
    brickColumnCount,
    brickRowCount,
    brickHeight,
    brickWidth,
    brickPadding,
    brickOffsetLeft,
    brickOffsetTop,
    context
} from "./exports.js";


const bricks = [];
for (let c = 0; c < brickColumnCount; c++) {
  bricks[c] = [];
  for (let r = 0; r < brickRowCount; r++) {
    bricks[c][r] = { x: 0, y: 0 };
  }
}

export let drawBricks = () => {
    for (let c = 0; c < brickColumnCount; c++) {
      for (let r = 0; r < brickRowCount; r++) {
        const brickX = c * (brickWidth + brickPadding) + brickOffsetLeft;
        const brickY = r * (brickHeight + brickPadding) + brickOffsetTop;
        bricks[c][r].x = brickX;
        bricks[c][r].y = brickY;
        context.beginPath();
        context.rect(0, 0, brickWidth, brickHeight);
        context.fillStyle = "#0095DD";
        context.fill();
        context.closePath();
      }
    }  
}