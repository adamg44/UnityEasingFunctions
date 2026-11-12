using UnityEngine;

/*
 Created by Adam Gomez

 Functions converted from: https://easings.net/
 Function Descriptions from: https://docs.phaser.io/api-documentation/namespace/math-easing
 */
public static class Ease
{
    /// <summary>
    /// Starts slowly and accelerates toward the end, following the shape of a sine wave.
    /// <a href="https://easings.net/#easeInSine">More Info...</a>
    /// </summary>
    /// <param name="x"> Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InSine(float x)
    {
        return 1 - Mathf.Cos((x * Mathf.PI) / 2f);
    }


    /// <summary>
    /// Begins moving quickly and decelerates to a gentle stop, following the curve of a sine wave.
    /// <a href="https://easings.net/#easeOutSine">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutSine(float x)
    {
        return Mathf.Sin((x * Mathf.PI) / 2f);
    }


    /// <summary>
    /// Starts slowly, accelerates through the midpoint, and decelerates back to a stop at the end, producing a smooth S-curve transition.
    /// <a href="https://easings.net/#easeInOutSine">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutSine(float x)
    {
        return -(Mathf.Cos(Mathf.PI * x) - 1f) / 2f;
    }

    /// <summary>
    /// Accelerates gradually across the range, producing a smooth upward curve
    /// <a href="https://easings.net/#easeInQuad">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InQuad(float x)
    {
        return x * x;
    }


    /// <summary>
    /// Starts at peak speed and decelerates gradually across the range, producing a smooth downward curve.
    /// <a href="https://easings.net/#easeOutQuad">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutQuad(float x)
    {
        return 1f - (1f - x) * (1f - x);
    }


    /// <summary>
    /// Accelerates in the first half of the range and decelerates in the second half, producing a smooth S-curve transition.
    /// <a href="https://easings.net/#easeInOutQuad">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutQuad(float x)
    {
        return x < 0.5f ? 2f * x * x : 1f - Mathf.Pow(-2f * x + 2f, 2f) / 2f;
    }


    /// <summary>
    /// Starts slowly and accelerates sharply, producing a gradual start that builds into a fast finish.
    /// <a href="https://easings.net/#easeInCubic">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InCubic(float x)
    {
        return x * x * x;
    }

    /// <summary>
    /// Starts quickly and decelerates sharply, producing a snappy start that settles into a slow finish.
    /// <a href="https://easings.net/#easeOutCubic">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutCubic(float x)
    {
        return 1 - Mathf.Pow(1f - x, 3f);
    }


    /// <summary>
    /// Produces an S-curve that accelerates from zero, reaches maximum speed at the midpoint, then decelerates back to zero.
    /// <a href="https://easings.net/#easeInOutCubic">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutCubic(float x)
    {
        return x < 0.5f ? 4f * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 3f) / 2f;
    }

    /// <summary>
    /// Starts very slowly and accelerates sharply toward the end of the range, producing a steep upward curve. 
    /// <a href="https://easings.net/#easeInQuart">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InQuart(float x)
    {
        return x * x * x * x;
    }


    /// <summary>
    /// Starts quickly at peak speed and decelerates sharply toward a complete stop, producing a steep downward curve.
    /// <a href="https://easings.net/#easeOutQuart">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutQuart(float x)
    {
        return 1 - Mathf.Pow(1f - x, 4f);
    }


    /// <summary>
    /// Accelerates sharply from the start, then decelerates sharply into the end. 
    /// <a href="https://easings.net/#easeInOutQuart">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutQuart(float x)
    {
        return x < 0.5f ? 8f * x * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 4f) / 2f;
    }

    /// <summary>
    /// Starts changing very slowly and accelerates sharply toward the end.
    /// <a href="https://easings.net/#easeInQuint">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InQuint(float x)
    {
        return x * x * x * x * x;
    }


    /// <summary>
    /// Starts changing very quickly and decelerates sharply toward the end.
    /// <a href="https://easings.net/#easeOutQuint">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutQuint(float x)
    {
        return 1f - Mathf.Pow(1f - x, 5f);
    }


    /// <summary>
    /// Begins slowly, accelerates sharply through the midpoint, then decelerates back to a slow stop.
    /// <a href="https://easings.net/#easeInOutQuint">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutQuint(float x)
    {
        return x < 0.5f ? 16f * x * x * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 5f) / 2f;
    }

    /// <summary>
    /// Applies an exponential curve that remains nearly motionless at the start before accelerating dramatically toward the end of the range, producing an extreme upward curve.
    /// <a href="https://easings.net/#easeInExpo">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InExpo(float x)
    {
        return x == 0f ? 0f : Mathf.Pow(2f, 10f * x - 10f);
    }


    /// <summary>
    /// Applies an exponential curve that starts at maximum speed and decelerates rapidly, producing an extreme downward curve.
    /// <a href="https://easings.net/#easeOutExpo">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutExpo(float x)
    {
        return x == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * x);
    }


    /// <summary>
    /// Produces a curve that accelerates sharply from zero using an exponential curve in the first half, then decelerates symmetrically to a smooth stop.
    /// <a href="https://easings.net/#easeInOutExpo">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutExpo(float x)
    {
        return x == 0f
          ? 0f
          : x == 1f
          ? 1f
          : x < 0.5f ? Mathf.Pow(2f, 20f * x - 10f) / 2f
          : (2f - Mathf.Pow(2f, -20f * x + 10f)) / 2f;
    }

    /// <summary>
    /// Based on the equation of a circle, producing a curve that starts very slowly and then accelerates sharply toward the end.
    /// <a href="https://easings.net/#easeInCirc">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InCirc(float x)
    {
        return 1f - Mathf.Sqrt(1f - Mathf.Pow(x, 2f));
    }

    /// <summary>
    /// Based on the equation of a circle, producing a curve that starts at full speed and decelerates smoothly to a stop
    /// <a href="https://easings.net/#easeOutCirc">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutCirc(float x)
    {
        return Mathf.Sqrt(1f - Mathf.Pow(x - 1f, 2f));
    }


    /// <summary>
    /// Applies a circular easing curve that starts slow, accelerates through the midpoint, then decelerates to a smooth stop.
    /// <a href="https://easings.net/#easeInOutCirc">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutCirc(float x)
    {
        return x < 0.5f
          ? (1f - Mathf.Sqrt(1f - Mathf.Pow(2f * x, 2f))) / 2f
          : (Mathf.Sqrt(1f - Mathf.Pow(-2f * x + 2f, 2f)) + 1f) / 2f;
    }

    /// <summary>
    /// Starts by briefly pulling back in the opposite direction before moving forward, creating an anticipation effect at the beginning of the transition.
    /// <a href="https://easings.net/#easeInBack">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InBack(float x)
    {
        const float c1 = 1.70158f;
        const float c3 = c1 + 1f;
        return c3 * x * x * x - c1 * x * x;
    }



    /// <summary>
    /// Moves quickly at first, then overshoots its final value before settling back to the target. 
    /// <a href="https://easings.net/#easeOutBack">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutBack(float x)
    {
        const float c1 = 1.70158f;
        const float c3 = c1 + 1f;
        return 1f + c3 * Mathf.Pow(x - 1f, 3f) + c1 * Mathf.Pow(x - 1f, 2f);
    }


    /// <summary>
    /// Initially pulls back slightly before accelerating forward, then overshoots the target before snapping back to rest, producing a symmetrical spring-like motion. 
    /// <a href="https://easings.net/#easeInOutBack">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutBack(float x)
    {
        const float c1 = 1.70158f;
        const float c2 = c1 * 1.525f;
        return x < 0.5f
          ? (Mathf.Pow(2f * x, 2f) * ((c2 + 1f) * 2f * x - c2)) / 2f
          : (Mathf.Pow(2f * x - 2f, 2f) * ((c2 + 1f) * (x * 2f - 2f) + c2) + 2f) / 2f;
    }


    /// <summary>
    /// Oscillates back and forth with a spring-like motion before accelerating toward the target. The effect begins with a series of small oscillations that grow in magnitude, simulating a stretched elastic band being released. 
    /// <a href="https://easings.net/#easeInElastic">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InElastic(float x)
    {
        const float c4 = (2f * Mathf.PI) / 3f;
        return x == 0f
          ? 0f
          : x == 1f
          ? 1
          : -Mathf.Pow(2f, 10f * x - 10f) * Mathf.Sin((x * 10f - 10.75f) * c4);
    }


    /// <summary>
    /// Overshoots its target and oscillates with a decaying sine wave before settling at the final value. The elastic effect occurs at the end of the transition, making the motion appear to bounce or spring into place.
    /// <a href="https://easings.net/#easeOutElastic">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutElastic(float x)
    {
        const float c4 = (2f * Mathf.PI) / 3f;
        return x == 0f
          ? 0f
          : x == 1f
          ? 1f
          : Mathf.Pow(2f, -10f * x) * Mathf.Sin((x * 10f - 0.75f) * c4) + 1f;
    }


    /// <summary>
    /// Produces a spring-like oscillation at both the start and end of the tween, overshooting the target value before settling.
    /// <a href="https://easings.net/#easeInOutElastic">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutElastic(float x)
    {
        const float c5 = (2f * Mathf.PI) / 4.5f;
        return x == 0f
          ? 0f
          : x == 1f
          ? 1f
          : x < 0.5f
          ? -(Mathf.Pow(2f, 20f * x - 10f) * Mathf.Sin((20f * x - 11.125f) * c5)) / 2f
          : (Mathf.Pow(2f, -20f * x + 10f) * Mathf.Sin((20f * x - 11.125f) * c5)) / 2f + 1f;
    }



    /// <summary>
    /// The value will 'bounce' several times near the origin before accelerating toward the target, simulating the effect of a ball bouncing as it begins to move.
    /// <a href="https://easings.net/#easeInBounce">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InBounce(float x)
    {
        return 1f - OutBounce(1f - x);
    }


    /// <summary>
    /// The motion starts fast and decelerates toward the end with a bouncing effect, simulating a ball landing and bouncing to a stop.
    /// <a href="https://easings.net/#easeOutBounce">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float OutBounce(float x)
    {
        const float n1 = 7.5625f;
        const float d1 = 2.75f;

        if (x < 1f / d1)
        {
            return n1 * x * x;
        }
        else if (x < 2f / d1)
        {
            return n1 * (x -= 1.5f / d1) * x + 0.75f;
        }
        else if (x < 2.5f / d1)
        {
            return n1 * (x -= 2.25f / d1) * x + 0.9375f;
        }
        else
        {
            return n1 * (x -= 2.625f / d1) * x + 0.984375f;
        }
    }


    /// <summary>
    /// Produces a bouncing animation at the start and end of the motion.
    /// <a href="https://easings.net/#easeInOutBounce">More Info...</a>
    /// </summary>
    /// <param name="x">Represents the absolute progress of the animation in the bounds of 0 (beginning of the animation) and 1 (end of animation).</param>
    /// <returns></returns>
    public static float InOutBounce(float x)
    {
        return x < 0.5f
          ? (1f - OutBounce(1f - 2f * x)) / 2f
          : (1f + OutBounce(2f * x - 1f)) / 2f;
    }
}
