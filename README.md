README

I've decided to use my empty version of hypercasual template. This template just contains
UI and GameState(Loading, Main, Game and End) logic. First, i've created an environment. 
I've decided to work on a minimalist office. I think it looks cool with postprocess,
lightning, shadow setting, gradient texture and couple of particle effects.
Then made PlayerController class which casts rays to interactable objects. 
Since i never made a point&click game before, i've tought couple of versions.
Then decided to use current one. First we cast a ray to interactable object, then to another one. Once we have 2 interactable objects;
InteractableController class checks ActiveLevels Stage, if objects InteractableType matches; function returns true and goes next stage.
If stage equals ActiveLevels stage count then door ui became visible and we are able to finish level. 
Once door opened, we will see someone waits in there.

If we look at the optimisation; i think it is very acceptable. Since i dont use unnecessary Update functions and GetComponents everywhere, i think code optimisation is quite good. I have made some material settings (like cpu instancing), texture size reduce and used only scene objects (not pooled, i didnt think object pool is necessary in this project, like we only have one every each particles etc.) and never instantiated new gameobjects. 

![Screenshot_2](https://user-images.githubusercontent.com/24496846/195956237-3c52c463-c78f-45e6-93fb-b041b63fed8b.jpg)
