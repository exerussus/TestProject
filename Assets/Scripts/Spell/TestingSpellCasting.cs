﻿
using UnityEngine;

public class TestingSpellCasting : MonoBehaviour
{
    [SerializeField] private KeyboardController keyboardController;
    [SerializeField] private Spell spell;
    [SerializeField] private Character caster;
    [SerializeField] private Transform casterTransform;
    [SerializeField] private SpellEffectHandler casterSpellEffectHandler;

    public void OnEnable()
    {
        keyboardController.OnJump += Cast;
    }

    public void OnDisable()
    {
        keyboardController.OnJump -= Cast;
    }
    
    public void Cast()
    {
        SpellCaster.CastSpell(casterTransform, caster, spell, casterSpellEffectHandler);
    }
}
