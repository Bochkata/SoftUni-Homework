using System;

namespace P03_BarraksWars.Core.Factories
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class InjectAttribute : Attribute
    {
    }
}