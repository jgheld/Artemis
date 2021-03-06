﻿using System.Windows.Media;
using Artemis.Models.Interfaces;
using Artemis.Models.Profiles.Properties;
using Artemis.Utilities;

namespace Artemis.ViewModels.Profiles.Properties
{
    public class MousePropertiesViewModel : LayerPropertiesViewModel
    {
        private Brush _brush;
        private LayerPropertiesModel _proposedProperties;

        public MousePropertiesViewModel(IDataModel dataModel, LayerPropertiesModel properties)
            : base(dataModel)
        {
            ProposedProperties = GeneralHelpers.Clone(properties);
            Brush = ProposedProperties.Brush.CloneCurrentValue();
        }

        public Brush Brush
        {
            get { return _brush; }
            set
            {
                if (Equals(value, _brush)) return;
                _brush = value;
                NotifyOfPropertyChange(() => Brush);
            }
        }

        public LayerPropertiesModel ProposedProperties
        {
            get { return _proposedProperties; }
            set
            {
                if (Equals(value, _proposedProperties)) return;
                _proposedProperties = value;
                NotifyOfPropertyChange(() => ProposedProperties);
            }
        }

        public override LayerPropertiesModel GetAppliedProperties()
        {
            var properties = GeneralHelpers.Clone(ProposedProperties);
            properties.Brush = Brush;
            return properties;
        }
    }
}