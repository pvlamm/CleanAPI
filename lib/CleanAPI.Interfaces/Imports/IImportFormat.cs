using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanAPI.Interfaces.Imports {
    public interface IImportFormat {
        Task<IEnumerable<TEntity>> LoadFile<TEntity>(IMapper mapper);
    }
}