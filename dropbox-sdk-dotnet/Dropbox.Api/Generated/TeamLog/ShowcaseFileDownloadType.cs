// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The showcase file download type object</para>
    /// </summary>
    public class ShowcaseFileDownloadType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShowcaseFileDownloadType> Encoder = new ShowcaseFileDownloadTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShowcaseFileDownloadType> Decoder = new ShowcaseFileDownloadTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseFileDownloadType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public ShowcaseFileDownloadType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShowcaseFileDownloadType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ShowcaseFileDownloadType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the showcase file download type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShowcaseFileDownloadType" />.</para>
        /// </summary>
        private class ShowcaseFileDownloadTypeEncoder : enc.StructEncoder<ShowcaseFileDownloadType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShowcaseFileDownloadType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShowcaseFileDownloadType" />.</para>
        /// </summary>
        private class ShowcaseFileDownloadTypeDecoder : enc.StructDecoder<ShowcaseFileDownloadType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShowcaseFileDownloadType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShowcaseFileDownloadType Create()
            {
                return new ShowcaseFileDownloadType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShowcaseFileDownloadType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
