﻿namespace PacmanBot.Domain.Unit.Behaviuor;

public interface IBehaviour<T>
{
    IBehaviour<T>? OnSuccess { get; set; }
    IBehaviour<T>? OnFail { get; set; }
    void Handle(T state);
}