﻿using mefit_backend.models.domain;

namespace mefit_backend.Services
{
    public interface IWorkoutService
    {
        public Task<IEnumerable<Workout>> GetWorkouts();
        Task<Workout> GetWorkoutById(int id);
        Task<Workout> AddWorkout(Workout workout);
        Task DeleteWorkout(int id);
        Task<Workout> UpdateWorkout(Workout workout);

        public Task UpdateWorkoutExercisesInWorkout(int[] workoutExercisesIds, int workoutId);
    }
}
