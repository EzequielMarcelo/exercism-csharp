using System;

class RemoteControlCar
{
    private int _distanceDriven;
    private int _batteryPercentage;

    public RemoteControlCar()
    {
        _distanceDriven = 0;
        _batteryPercentage = 100;
    }

    public static RemoteControlCar Buy() => new();
    
    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => 
        _batteryPercentage == 0 ? "Battery empty" : $"Battery at {_batteryPercentage}%";

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceDriven += 20;
            _batteryPercentage -= 1;
        }
    }
}
