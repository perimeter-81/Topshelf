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

            if (splitIndex < 0)
            {
                // only value
                argName = value;
            }
            else
            {
                // name:value
                argName = value.Substring(0, splitIndex);
                argValue = value.Substring(splitIndex + 1);
            }
        }

        public void ApplyTo(HostConfigurator configurator)
        {
            // argValue is null if the argument is not a `name:value` pair
            configurator.AddServiceArgument(argName, argValue);
        }
    }
}
