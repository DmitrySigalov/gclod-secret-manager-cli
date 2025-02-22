namespace GCloud.Secret.Client.EnvironmentVariables;

public interface IEnvironmentVariablesProvider
{
    EnvironmentDescriptor Get();

    void Set(EnvironmentDescriptor newData,
        Action<string> outputCallback);
}