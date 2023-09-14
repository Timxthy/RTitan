using System;
namespace Q3
{
    public interface IDriveable
    {
        void EngineOn();
        void MoveForwardAtKMPH(int speed);
        void EngineOff();
    }

}

