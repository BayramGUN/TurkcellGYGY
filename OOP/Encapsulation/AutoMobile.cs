namespace Encapsulation;

public class AutoMobile
{
    private int speed = 0;
    private bool isWork = false;
    public void StartEngine()
    {
        isWork = true;
    }

    public void StepOnTheGas()
    {
        if (isWork) speed++;
        else Console.WriteLine("The automobile is not working!");
    }

    public void StopEngine()
    {
        if(isWork || speed > 0) speed = 0;
    }
}