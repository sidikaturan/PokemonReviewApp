﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Intefaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReview(int reviewId);

        ICollection<Review> GetReviewsOfAPokemon(int pokeId);

        bool ReviewExist(int reviewId);

        bool CreateReview(Review review);

        bool UpdateReview(Review review);

        bool DeleteReview(Review review);

        bool DeleteReviews(List<Review> reviews);

        bool Save();

    }
}
