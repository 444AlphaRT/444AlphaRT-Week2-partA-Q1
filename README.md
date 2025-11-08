🌀 Week 2 – Part A – Question 1

Unity Project – 2D Character Oscillation System

🎮 Play the game on Itch.io:

⸻

✅ Description

A simple Unity project that demonstrates oscillating motion applied to three characters:
Peter, Louis, and Brian.

Each character moves back and forth along a defined axis (right/left, up/down, or diagonal).
Movement is smooth, periodic, and driven by a customizable sine-wave function.

⸻

✅ What it demonstrates
	•	Smooth back-and-forth oscillation using Mathf.Sin()
	•	Adjustable motion parameters:
	•	Direction (Vector2)
	•	Amplitude (distance from center)
	•	Period (seconds per cycle)
	•	Phase offset (for desynchronized motion)
	•	Clean separation of configuration using SerializeField
	•	Reusing the same script for multiple characters
	•	Basic Unity scene setup with 2D sprites & components

⸻

✅ How it works (concept)

The script Oscillator.cs:
	1.	Saves the character’s initial position as its center point.
	2.	Calculates a theta angle from time, period, and phase.
	3.	Uses Mathf.Sin(theta) to get a repeating -1 → +1 motion value.
	4.	Multiplies this value by:
	•	direction
	•	amplitude
	5.	Adds the offset to the original center → resulting in smooth oscillation.

Each character in the scene uses the same script but with different parameters, creating variation in speed, direction, and timing.
