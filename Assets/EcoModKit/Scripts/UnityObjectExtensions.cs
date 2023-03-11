using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public static class UnityObjectExtensions
{
    public static string GetScenePath(this Component b) => GetScenePath(b.transform);
    public static string GetScenePath(this GameObject g) => GetScenePath(g.transform);

    public static string GetScenePath(this Transform t) => AppendScenePath(new StringBuilder(), t).ToString();
    public static StringBuilder AppendScenePath(StringBuilder sb, Transform t)
    {
        var parent = t.parent;
        if (parent != null)
            AppendScenePath(sb, parent).Append('/');
        sb.Append(t.name);
        return sb;
    }

    /// <summary> Gets or adds a component of type <typeparamref name="T"/>. </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component => gameObject.TryGetComponent<T>(out var component) ? component : gameObject.AddComponent<T>();

    /// <summary> Gets or adds a component of the provided type. </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Component GetOrAddComponent(this GameObject gameObject, Type componentType) => gameObject.TryGetComponent(componentType, out var component) ? component : gameObject.AddComponent(componentType);

    /// <summary> Checks if <paramref name="gameObject"/> has a component of type <typeparamref name="T"/>. </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasComponent<T>(this GameObject gameObject) => gameObject.TryGetComponent<T>(out _);

    /// <summary> Checks if <paramref name="component"/> has a component of type <typeparamref name="T"/>. </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasComponent<T>(this Component component) => component.gameObject.TryGetComponent<T>(out _);

}
