﻿using Rabbit.Cloud.Facade.Abstractions.MessageBuilding;
using System;

namespace Rabbit.Cloud.Facade.Abstractions
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = true)]
    public class ToFormAttribute : Attribute, IBuilderTargetMetadata, IBuilderModelNameProvider
    {
        public ToFormAttribute()
        {
        }

        public ToFormAttribute(string name)
        {
            Name = name;
        }

        public ToFormAttribute(string name, string value)
        {
            Name = name;
            Value = value;
            BuildingTarget = BuildingTarget.Custom;
        }

        #region Implementation of IBuildingTargetMetadata

        public BuildingTarget BuildingTarget { get; } = BuildingTarget.Form;

        #endregion Implementation of IBuildingTargetMetadata

        #region Implementation of IBuildingModelNameProvider

        public string Name { get; }

        #endregion Implementation of IBuildingModelNameProvider

        public object Value { get; }
    }
}