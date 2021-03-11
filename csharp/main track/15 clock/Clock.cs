using System;

public readonly struct Clock {
    private const int MINUTES_HOUR = 60;
    private const int MINUTES_DAY = 1440;

    public Clock (int hours, int minutes) 
        : this ((hours * MINUTES_HOUR + minutes) % MINUTES_DAY) {}

    public Clock (int minutes) {
        TotalMinutes = minutes + (minutes < 0 ? MINUTES_DAY : 0);
    }

    public int TotalMinutes { get; }

    public override string ToString() => $"{(TotalMinutes / MINUTES_HOUR).ToString("D2")}:{(TotalMinutes % MINUTES_HOUR).ToString("D2")}";

    public Clock Add(int minutesToAdd) => Subtract(-minutesToAdd);

    public Clock Subtract(int minutesToSubtract)
    {
        int newMinutes = (TotalMinutes - minutesToSubtract) % MINUTES_DAY;
        return new Clock(newMinutes < 0 ? (newMinutes + MINUTES_DAY) : newMinutes);
    }
}