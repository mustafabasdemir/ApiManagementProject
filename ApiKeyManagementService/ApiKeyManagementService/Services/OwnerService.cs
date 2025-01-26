using ApiKeyManagementService.Data;
using ApiKeyManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiKeyManagementService.Services
{
    public class OwnerService
    {
        private readonly AppDbContext _context;

        public OwnerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Owner>> GetAllOwnersAsync()
        {
            return await _context.Owners.ToListAsync();
        }

        public async Task<Owner?> GetOwnerByIdAsync(int id)
        {
            return await _context.Owners.FindAsync(id);
        }

        public async Task AddOwnerAsync(Owner owner)
        {
            await _context.Owners.AddAsync(owner);
            await _context.SaveChangesAsync();
        }

        public async Task<Owner?> UpdateOwnerAsync(int id, Owner owner)
        {
            var existingOwner = await _context.Owners.FindAsync(id);
            if (existingOwner == null)
                return null;

            existingOwner.Name = owner.Name;
            existingOwner.Mail = owner.Mail;
            existingOwner.Type = owner.Type;

            await _context.SaveChangesAsync();
            return existingOwner;
        }

        public async Task<bool> DeleteOwnerAsync(int id)
        {
            var owner = await _context.Owners.FindAsync(id);
            if (owner == null)
                return false;

            _context.Owners.Remove(owner);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
