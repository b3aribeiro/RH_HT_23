# RH_HT_23 : I'llByte

"I’llByte" is a VR Haptic Jaw that has won the following prizes at MIT Reality Hack 2023:
- Best of Hardware Track
- Technology Horizons for Human Interfaces

The team was composed by: @b3aribeiro @elerwise @grass.obj @julia.daser @pepzicles

Inspiration
The current state of VR technology focuses on creating an immersive experience through sight, hearing and taste. However, as of today, there has not been a VR device that stimulates the jaw, even though eating and food are such integral parts of the human experience. With such an obvious gap in the VR industry, we decided to take on the challenge.

What it does
We created a futuristic jaw haptic device that consists of two parts- an adjustable jaw brace and a harness. The jaw brace is made of aluminum wire and rubber bands, and can be adjusted to fit the facial profile of different users. The jaw brace is then attached to the harness via springs. The tension on the springs can be adjusted via motors. This means that when a user “eats” a particular food item in the XR experience, depending on the texture of the food item, the tension in the springs are adjusted automatically. This simulates the extent of difficulty or ease in chewing different items in an XR experience.

How we built it
I’llByte was built in Unity 2021.3.16f. When the VR controllers interact with a food item, the program sends a bluetooth message via MIT’s The Singularity. Then the SDK connects with the microcontroller on the back of the harness, which spins the servo motors attached to the front of the harness. As a result, the springs attached to the jaw harness are pulled, creating tension dependent on the VR experience. 3 different tension modes are set up for the prototype VR game, creating 3 different “textures” of foods.

Challenges we ran into
One of our biggest challenges was being a team of four designers and one game designer/game developer that came later down the road. This came with its pros, as we were able to refine the fabrication of our prototype, but this also meant that the development was very slow. Coding detailed interactions in unity with four designers was extremely challenging because it requires a lot of C# coding and only one of us knows C#. Most of our time was spent on testing The Singularity SDK as well, but luckily, we were the first team in the hardware track to successfully test it out. We had intended to use the Ultraleap so that we could use hand tracking instead of controllers, but the Quest 2 cannot connect with Ultraleap easily. The Quest 2 cannot connect with our Macbooks very well either.

What's next for I’llByte: VR Haptic Jaw
This prototype can be used to test and enjoy the food you create from VR cooking experiences, as well as increase accessibility of seasonal food experiences. It can also be used as a form of exposure therapy for people who have certain food fears, or a form of mobility therapy. If we were to iterate this prototype further, we would like to 3D print the components of the jaw brace with resin for greater accuracy and precision. This could also remove the tab that goes inside of the mouth from the design. We would also like to create four different sizes of the device for different facial and body profiles, as well as make use of foam and cloth to increase comfort for users. The jaw brace would have better adjustable pins to fine tune the fit.

Presentation slides for Reality Tank: https://docs.google.com/presentation/d/11LOJGDGdOa0t9eqebTAICtN3l31g9MoldPk1R0b5gT0/edit?usp=sharing
