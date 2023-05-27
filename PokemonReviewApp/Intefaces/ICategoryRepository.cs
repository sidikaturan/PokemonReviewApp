﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Intefaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        Category GetCategory(int id);

        ICollection<Pokemon> GetPokemonByCategory(int categoryId);

        bool CategoryExist(int id);

        bool CreateCategory (Category category);

        bool UpdateCategory(Category category);
        
        bool DeleteCategory(Category category);

        bool Save();
        
    }
}
