using System;

namespace RobocupSSLController
{
    public interface ICommandsOutput : IDisposable
    {
        /// <summary>
        /// Add commands to the queue, prepared to send to the robots
        /// </summary>
        /// <param name="commands">A commands to add to the queue. Will not be copied by the implementation, so the calling side should ensure not to modify it.</param>
        void PostCommands(RobotCommand[] commands);
    }
}