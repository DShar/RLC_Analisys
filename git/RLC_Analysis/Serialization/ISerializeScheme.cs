using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLC_Analysis.Serialization
{
    public interface ISerializeScheme<TWriter,TReader>
    {
        /// <summary>
        /// Serializes.
        /// </summary>
        /// <param name="writer">The writer that will be used to serialize the given <see cref="SimpleDiagramModel"/>.</param>
        void Serialize(TWriter writer);

        /// <summary>
        /// Deserializes a <see cref="SimpleDiagramModel"/>.
        /// </summary>
        /// <param name="reader">The reader that will be used to deserialize the given <see cref="SimpleDiagramModel"/>.</param>
        /// <returns>The deserialized diagram.</returns>
        void Deserialize(TReader reader);
    }
}
