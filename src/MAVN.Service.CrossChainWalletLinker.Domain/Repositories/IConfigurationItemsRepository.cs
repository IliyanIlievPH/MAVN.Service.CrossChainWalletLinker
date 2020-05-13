using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Common.MsSql;
using MAVN.Service.CrossChainWalletLinker.Domain.Enums;
using MAVN.Service.CrossChainWalletLinker.Domain.Models;

namespace MAVN.Service.CrossChainWalletLinker.Domain.Repositories
{
    public interface IConfigurationItemsRepository
    {
        Task UpsertAsync(ConfigurationItemType type, string value, TransactionContext txContext = null);

        Task<IConfigurationItem> GetAsync(ConfigurationItemType type, TransactionContext txContext = null);
        
        Task<IEnumerable<IConfigurationItem>> GetAllAsync(TransactionContext txContext = null);
    }
}
