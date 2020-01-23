namespace RobocupSSLController
{
    public struct RobotCommand
    {
        public double VelocityTangent { get; set; }
        public double VelocityNormal { get; set; }
        public double AngularVelocity { get; set; }
        
        public bool EnableDribbler { get; set; }
        
        public double KickSpeedX { get; set; }
        public double KickSpeedZ { get; set; }
        
        public static RobotCommand Idle =>
            new RobotCommand
            {
                AngularVelocity = 0,
                VelocityNormal = 0,
                VelocityTangent = 0,
                EnableDribbler = false,
                KickSpeedX = 0,
                KickSpeedZ = 0,
            };
    }
}