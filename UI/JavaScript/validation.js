function validate() {
    // return false;
    var reqInputs = document.getElementsByClassName('required');
    let isValid = true;
    for(let i = 0; i < reqInputs.length; i++) { 
        const element = reqInputs[i];
        isValid = (isRequired(element) && isValid);
    };
    
    return isValid;     
}

function isRequired(element){
    let isAvailable = true;
    let value = element.value;
    if(value === '') {
        let message = element.getAttribute('data-message');
        let span = element.getAttribute('data-target');
        element.addEventListener('change', () => {
            document.getElementById(span).innerText = '';
        });
        document.getElementById(span).innerText = message;
        target.innerText = message;
        isAvailable = false;
    }
    return isAvailable;
}