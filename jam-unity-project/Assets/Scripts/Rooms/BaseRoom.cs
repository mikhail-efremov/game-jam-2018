﻿using UnityEngine;

public abstract class BaseRoom : MonoBehaviour
{
  public int Health;

  public void Use(Player player)
  {
    if(Health == 0)
      return;

    UseImpl(player);
  }

  protected abstract void UseImpl(Player player);
}