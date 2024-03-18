namespace CarFactoryLibrary
{
    public abstract class Car
    {
        // speed =velocity
        public double velocity { get; set; }
        //How the car work? Backword or forward
        public DrivingMode drivingMode { get; set; }
        //def constructor
        public Car()
        {
            velocity = 0;
            drivingMode = DrivingMode.Stopped;
        }


        // car is stop or not ?
        public Boolean IsStopped()
        {
            return velocity == 0 ? true : false;
        }

        // function stop the car 
        public void Stop()
        {
            velocity = 0;
            drivingMode = DrivingMode.Stopped;
        }
        //increase speed and move the car forward
        public void IncreaseVelocity(double addedVelocity)
        {
            velocity += addedVelocity;
            drivingMode = DrivingMode.Forward;
        }

        public abstract void Accelerate();
        
        public string GetDirection()
        {
            return drivingMode.ToString();
        }
        //return refrence for the same object
        public Car GetMyCar()
        {
            return this;
        }


        public double TimeToCoverDistance(double distance)
        {
            return distance / velocity;
        }
        //compare btween 2 cars 
        public override bool Equals(object? obj)
        {
            Car? car = obj as Car;
            if (car == null) return false;

            return car.velocity == velocity && car.drivingMode == drivingMode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.drivingMode, this.velocity);
        }
    }
}