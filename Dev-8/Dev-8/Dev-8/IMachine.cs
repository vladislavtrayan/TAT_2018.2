using System;
namespace Dev_5
{
    /// <summary>
    /// Represents all  machines
    /// </summary>
    public interface IMachine
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Capacity { get; set; }
        double Cost { get; set; }
    }
}
