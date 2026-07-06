// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace.Meta
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class MetaDataAttribute : Attribute
    {
        private readonly Type _modelType;
        private WeakReference<MetaModel>? _currentModel;
        public MetaModel? Model 
        { 
            get
            {
                MetaModel? result;

                if (_currentModel?.TryGetTarget(out result) is true)
                {
                    return result;
                }
                else
                {
                    result = Activator.CreateInstance(_modelType) as MetaModel;
                    if (result is not null)
                    {
                        if (_currentModel is null) 
                            _currentModel = new WeakReference<MetaModel>(result);
                        else
                            _currentModel.SetTarget(result);
                        return result;
                    }
                }
                throw new InvalidOperationException($"the MetaModel {_modelType.FullName}, could not be created");
            }
        }
        public string? DomainName { get; set; }
        public MetaDataAttribute(Type model, string? domainName = null)
        {
            _modelType = model;
            DomainName = domainName;
        }
    }
}
