// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>ArcType</c> to a <see cref="CesiumOutputStream"/>. A <c>ArcType</c> is the type of an arc.
    /// </summary>
    public class ArcTypeCesiumWriter : CesiumPropertyWriter<ArcTypeCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumArcTypeValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>arcType</c> property.
        /// </summary>
        public const string ArcTypePropertyName = "arcType";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumArcTypeValuePropertyAdaptor<ArcTypeCesiumWriter>> m_asArcType;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<ArcTypeCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public ArcTypeCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asArcType = CreateAsArcType();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ArcTypeCesiumWriter([NotNull] ArcTypeCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asArcType = CreateAsArcType();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override ArcTypeCesiumWriter Clone()
        {
            return new ArcTypeCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>arcType</c>, which is the arc type.
        /// </summary>
        /// <param name="value">The type of an arc.</param>
        public void WriteArcType(CesiumArcType value)
        {
            const string PropertyName = ArcTypePropertyName;
            if (ForceInterval)
            {
                OpenIntervalIfNecessary();
            }
            if (IsInterval)
            {
                Output.WritePropertyName(PropertyName);
            }
            Output.WriteValue(CesiumFormattingHelper.ArcTypeToString(value));
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the arc type specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the arc type specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the arc type specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the arc type specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumArcTypeValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumArcTypeValuePropertyAdaptor<ArcTypeCesiumWriter> AsArcType()
        {
            return m_asArcType.Value;
        }

        private Lazy<CesiumArcTypeValuePropertyAdaptor<ArcTypeCesiumWriter>> CreateAsArcType()
        {
            return new Lazy<CesiumArcTypeValuePropertyAdaptor<ArcTypeCesiumWriter>>(CreateArcType, false);
        }

        private CesiumArcTypeValuePropertyAdaptor<ArcTypeCesiumWriter> CreateArcType()
        {
            return CesiumValuePropertyAdaptors.CreateArcType(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<ArcTypeCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<ArcTypeCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<ArcTypeCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<ArcTypeCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}