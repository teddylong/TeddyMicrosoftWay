
function foo() {

  
    var tw1 = document.getElementById("TransformDiv");
    tw1.style.color = "blue";
    tw1.style.fontSize = "large";
    tw1.style.border = "thin solid #FF0000";
    tw1.style.borderRadius = "1em";
    tw1.style.borderColor = "green";

    $('#buttonOne').addClass('animated bounceIn');
}

function changeColor(newColor) {
    var tw = document.getElementById("WelcomeWord");
    tw.style.color = newColor;
}

function flashOfTransformDiv()
{
    $('#TransformDiv').addClass('animated flip');
}


