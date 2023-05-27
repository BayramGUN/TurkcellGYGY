import { drawBall } from "./ball.js";
import { drawPaddle } from "./paddle.js";
//import { drawBricks } from "./bricks.js";
import { 
    context,
    width, 
    height,
    ballRadius, 
    paddleWidth,
    paddleHeight,
    /* brickColumnCount,
    brickRowCount,
    brickHeight,
    brickWidth,
    brickPadding,
    brickOffsetLeft,
    brickOffsetTop, */
} from "./exports.js";

//to draw red square on canvas:
context.beginPath();
context.rect(20, 40, 50, 50);
context.fillStyle = "#FF0000";
context.fill();
context.closePath();

//to draw green circle on canvas:
context.beginPath();
context.rect(240, 160, 20, 0, Math.PI * 2, false);
context.fillStyle = "#green"
context.fill();
context.closePath();

// colored outer stroke:
context.beginPath();
context.rect(160, 10, 100, 40);
context.strokeStyle = "rgba(0, 0, 255, .5)";
context.stroke();
context.closePath();


// keyhandlers:
var rightPressed = false;
var leftPressed = false;

document.addEventListener("keydown", keyDownHandler, false);
document.addEventListener("keyup", keyUpHandler, false);

function keyDownHandler(e) {
    if(e.key === "Right" || e.key === "ArrowRight") {
        rightPressed = true;
    }
    else if(e.key === "Left" || e.key === "ArrowLeft") {
        leftPressed = true;
    }
}

function keyUpHandler(e) {
    if(e.key === "Right" || e.key === "ArrowRight") {
        rightPressed = false;
    }
    else if(e.key === "Left" || e.key === "ArrowLeft") {
        leftPressed = false;
    }
}

// set first position of the ball:

// (x axis value on canvas)
let x = width / 2;
// (y axis value on canvas)
let y = height - 30;


// set values of ball replacing value on canvas:
let dx = 2;
let dy = -2;

const brickRowCount = 3;
const brickColumnCount = 5;
const brickWidth = 75;
const brickHeight = 20;
const brickPadding = 10;
const brickOffsetTop = 30;
const brickOffsetLeft = 30;
  
let paddleX = (paddleWidth - paddleHeight) / 2;
// draw function for drawing ball animation on canvas.
function draw() {
    context.clearRect(0, 0, width, height)
    drawBricks();
    drawBall(x, y);
    drawPaddle(paddleX);
    // ball bouncing from the edge of canvas:
    if( x + dx > width - ballRadius || x + dx < ballRadius) {
        dx = -dx;
    }
    if( y + dy < ballRadius) {
        dy = -dy;
    }
    else if( y + dy > height - ballRadius ) {
        if(x > paddleX && x < paddleX + paddleWidth) {
            dy = -dy;
        }
        else {
            swal({
                title: "GAME OVER!",
                text: "Press OK to try again!",
                buttons: {
                    no: "NO!",
                    ok: "OK!"},
                    icon: "error",
                }).then((value) => {
                    switch (value) {
                        case "ok":
                            document.location.reload();
                            break;

                            case "no":
                                document.location.closePath();
                                break;
                            }
                        });
                        clearInterval(interval); // Needed for Chrome to end game
                    }
        }
                
    if(rightPressed) {
        paddleX += 7;
        if (paddleX + paddleWidth > width){
            paddleX = width - paddleWidth;
        }
    }
    else if(leftPressed) {
        paddleX -= 7;
        if (paddleX < 0){
            paddleX = 0;
        }
    }
    
    
    x += dx;
    y += dy;
}

//setInterval: draw ball every 10 ms. for moving ball animation.
const interval = setInterval(draw, 10);


var bricks = [];
for (let c = 0; c < brickColumnCount; c++) {
  bricks[c] = [];
  for (let r = 0; r < brickRowCount; r++) {
    bricks[c][r] = { x: 0, y: 0 };
  }
}

function drawBricks(){
    for (let c = 0; c < brickColumnCount; c++) {
      for (let r = 0; r < brickRowCount; r++) {
        var  brickX = c * (brickWidth + brickPadding) + brickOffsetLeft;
        var  brickY = r * (brickHeight + brickPadding) + brickOffsetTop;
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