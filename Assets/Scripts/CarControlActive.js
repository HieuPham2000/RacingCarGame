var CarControl : GameObject;
var Dreamcar01 : GameObject;
function Start() {
    CarControl.GetComponent("CarController").enabled = true;
    Dreamcar01.GetComponent("CarAIControl").enabled = true;
}