public class SpaceAge
{
    private readonly int _seconds = 0;
    private readonly double _earthOrbitalPeriodInSeconds = 31557600;

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth() => _seconds / _earthOrbitalPeriodInSeconds;

    public double OnMercury() => CalculateSpaceAge(0.2408467);

    public double OnVenus() => CalculateSpaceAge(0.61519726);

    public double OnMars() => CalculateSpaceAge(1.8808158);

    public double OnJupiter() => CalculateSpaceAge(11.862615);

    public double OnSaturn() => CalculateSpaceAge(29.447498);

    public double OnUranus() => CalculateSpaceAge(84.016846);

    public double OnNeptune() => CalculateSpaceAge(164.79132);

    private double CalculateSpaceAge(double orbitalPeriod) => _seconds / (_earthOrbitalPeriodInSeconds * orbitalPeriod);
}