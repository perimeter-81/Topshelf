namespace Topshelf.Options
{
    using HostConfigurators;

    public class ServiceArgOption : Option
    {
        private readonly string argName;
        private readonly string argValue;

        public ServiceArgOption(string value)
        {
            var splitIndex = value.IndexOf(':');
            argName = value.Substring(0, splitIndex);
            argValue = value.Substring(splitIndex + 1);
        }

        public void ApplyTo(HostConfigurator configurator)
        {
            configurator.AddServiceArgument(argName, argValue);
        }
    }
}
