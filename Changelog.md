# Changelog
---

### NFOGenerator v0.6.7-Alpha  (Mar. 06, 2017)

**"Ubiquitous Tribble"**

Features (1):

> * Search for imdb id base on title

Bugfixes (3):

> * Fix the bug that the title doesn't update when separate char changes
> * Fix the bug that display "1.0 channel" as "1.0 channels"
> * Fix the audio info bug so that info extracted by mediainfo can be used to generate release name

Tweaks (4):

> * Add the file input dialog back as an alternative input method
> * Label turns red if there are "Unknown" items, also the program will prompt when you click the process button
> * Add support for 576p resolution
> * Use a more precise method to determine channel layout

### NFOGenerator v0.5.0-Alpha  (Mar. 03, 2017)

**"Supreme Happiness"**

Initial release:
> * Retrieve and display critical media info's from a given media file
> * Guess release info from the file name
> * Generate a release name according to the given information
> * Generate a *.NFO file automatically
> * Currently support movie encodes only