﻿using System.ComponentModel;
using Artemis.Models.Interfaces;
using Artemis.Utilities;
using static System.Decimal;

namespace Artemis.Models.Profiles.Properties
{
    public class DynamicPropertiesModel
    {
        /// <summary>
        ///     Property this dynamic property applies on
        /// </summary>
        public string LayerProperty { get; set; }

        /// <summary>
        ///     Property to base the percentage upon
        /// </summary>
        public string GameProperty { get; set; }

        /// <summary>
        ///     Percentage source, the number that defines 100%
        /// </summary>
        public double PercentageSource { get; set; }

        /// <summary>
        ///     Percentage source property, the property that defines 100%
        /// </summary>
        public string PercentageProperty { get; set; }

        /// <summary>
        ///     Type of property
        /// </summary>
        public LayerPropertyType LayerPropertyType { get; set; }

        /// <summary>
        ///     Extra options on top of the selected properties
        /// </summary>
        public LayerPropertyOptions LayerPropertyOptions { get; set; }

        internal void ApplyProperty(IDataModel dataModel, ref AppliedProperties properties)
        {
            if (LayerPropertyType == LayerPropertyType.PercentageOf)
                ApplyPercentageOf(dataModel, ref properties, PercentageSource);
            if (LayerPropertyType == LayerPropertyType.PercentageOfProperty)
                ApplyPercentageOfProperty(dataModel, ref properties);
        }

        private void ApplyPercentageOf(IDataModel dataModel, ref AppliedProperties properties, double src)
        {
            if (GameProperty == null)
                return;

            var gameProperty = dataModel.GetPropValue<int>(GameProperty);
            var percentage = ToDouble(gameProperty)/src;

            if (LayerProperty == "Width")
                ApplyWidth(ref properties, percentage);
            else if (LayerProperty == "Height")
                ApplyHeight(ref properties, percentage);
            else if (LayerProperty == "Opacity")
                ApplyOpacity(ref properties, percentage);
        }

        private void ApplyWidth(ref AppliedProperties properties, double percentage)
        {
            var newWidth = percentage*properties.Width;
            var difference = properties.Width - newWidth;
            properties.Width = newWidth;

            // Apply the right to left option
            if (LayerPropertyOptions == LayerPropertyOptions.RightToLeft)
                properties.X = properties.X + difference;
        }

        private void ApplyHeight(ref AppliedProperties properties, double percentage)
        {
            var newHeight = percentage*properties.Height;
            var difference = properties.Height - newHeight;
            properties.Height = newHeight;

            if (LayerPropertyOptions == LayerPropertyOptions.Downwards)
                properties.Y = properties.Y + difference;
        }

        private void ApplyOpacity(ref AppliedProperties properties, double percentage)
        {
            properties.Opacity = percentage*properties.Opacity;
            if (properties.Opacity < 0.0)
                properties.Opacity = 0.0;
            if (properties.Opacity > 1.0)
                properties.Opacity = 1.0;

            // Apply the inverse/decrease option
            if (LayerPropertyOptions == LayerPropertyOptions.Decrease)
                properties.Opacity = 1.0 - properties.Opacity;
        }

        private void ApplyPercentageOfProperty(IDataModel dataModel, ref AppliedProperties properties)
        {
            var value = dataModel.GetPropValue<int>(PercentageProperty);
            ApplyPercentageOf(dataModel, ref properties, value);
        }
    }

    public enum LayerPropertyType
    {
        [Description("% of")] PercentageOf,
        [Description("% of property")] PercentageOfProperty
    }

    public enum LayerPropertyOptions
    {
        [Description("Left to right")] LeftToRight,
        [Description("Right to left")] RightToLeft,
        [Description("Downwards")] Downwards,
        [Description("Upwards")] Upwards,
        [Description("Increase")] Increase,
        [Description("Decrease")] Decrease
    }
}