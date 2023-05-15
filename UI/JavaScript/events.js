
function clickon(event) {
    console.log(event);
    event.cancelBubble = true;
    var target = event.target;
    target.style = 'background-color: pink';
    alert('button')
    switch(target.id){
        case 'panel':
            target.style = 'background-color: aqua';
            break;
        case 'container':
            target.style = 'background-color: yellowgreen';
            break;
        case 'section':
            target.style = 'background-color: gray';
            break;
        case 'button':
            target.style = 'background-color: pink';
            break;   
        }
        
}
document.getElementById('alt').addEventListener('click', () => {
    alert('çalıştıığğ');
});
