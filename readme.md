 System.InvalidOperationException
  HResult=0x80131509
  Message=Cannot create instance of type 'JsonConstructorIssue.DataCenterJsonConfig' because parameter 'dataCenter' has no matching config. Each parameter in the constructor that does not have a default value must have a corresponding config entry.
  Source=Microsoft.Extensions.Configuration.Binder
  StackTrace:
   at Microsoft.Extensions.Configuration.ConfigurationBinder.BindParameter(ParameterInfo parameter, Type type, IConfiguration config, BinderOptions options)
   at Microsoft.Extensions.Configuration.ConfigurationBinder.CreateInstance(Type type, IConfiguration config, BinderOptions options)
   at Microsoft.Extensions.Configuration.ConfigurationBinder.BindInstance(Type type, BindingPoint bindingPoint, IConfiguration config, BinderOptions options)
   at Microsoft.Extensions.Configuration.ConfigurationBinder.Get(IConfiguration configuration, Type type, Action`1 configureOptions)
   at Microsoft.Extensions.Configuration.ConfigurationBinder.Get[T](IConfiguration configuration, Action`1 configureOptions)
   at Microsoft.Extensions.Configuration.ConfigurationBinder.Get[T](IConfiguration configuration)
   at Program.<Main>$(String[] args) in D:\lab\JsonConstructorIssue\JsonConstructorIssue\Program.cs:line 16
