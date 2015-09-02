﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.Samples.MembershipAndRoleProvider
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.Samples.MembershipAndRoleProvider", ConfigurationName="Microsoft.Samples.MembershipAndRoleProvider.ICalculator")]
    public interface ICalculator
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/Add", ReplyAction="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/Subtract", ReplyAction="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/Multiply", ReplyAction="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/Divide", ReplyAction="http://Microsoft.Samples.MembershipAndRoleProvider/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICalculatorChannel : Microsoft.Samples.MembershipAndRoleProvider.ICalculator, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<Microsoft.Samples.MembershipAndRoleProvider.ICalculator>, Microsoft.Samples.MembershipAndRoleProvider.ICalculator
    {
        
        public CalculatorClient()
        {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public double Add(double n1, double n2)
        {
            return base.Channel.Add(n1, n2);
        }
        
        public double Subtract(double n1, double n2)
        {
            return base.Channel.Subtract(n1, n2);
        }
        
        public double Multiply(double n1, double n2)
        {
            return base.Channel.Multiply(n1, n2);
        }
        
        public double Divide(double n1, double n2)
        {
            return base.Channel.Divide(n1, n2);
        }
    }
}