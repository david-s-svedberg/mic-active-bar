<div id="top"></div>

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![MIT License][license-shield]][license-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/david-s-svedberg/mic-active-bar">
    <img src="no_sound.ico" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">MicActiveBar</h3>

  <p align="center">
    System tray icon that shows if your microphone is picking up sound.
    <br />
    <a href="https://github.com/david-s-svedberg/mic-active-bar"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    ·
    <a href="https://github.com/david-s-svedberg/mic-active-bar/issues">Report Bug</a>
    ·
    <a href="https://github.com/david-s-svedberg/mic-active-bar/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

### Built With

* [.Net 6](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-6)
* [Command Line Parser](https://github.com/commandlineparser/commandline)
* [NAudio](https://github.com/naudio/NAudio)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/david-s-svedberg/mic-active-bar.git
   ```
2. Open solution in Visual Studio

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Simply run the generated .exe.

There are two commandline parameters:
* -d | --darken Sets how much the icon should be darkened when sound is registered
* -t | --threshold Sets how high the sound has to be to trigger the change of icon

Make sure to add the icon to the list of icons that should always be visible by going to Settings->Taskbar->Select which icons appear on the taskbar

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Project Link: [https://github.com/david-s-svedberg/mic-active-bar](https://github.com/david-s-svedberg/mic-active-bar)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[issues-shield]: https://img.shields.io/github/issues/david-s-svedberg/mic-active-bar.svg?style=for-the-badge
[issues-url]: https://github.com/david-s-svedberg/mic-active-bar/issues
[license-shield]: https://img.shields.io/github/license/david-s-svedberg/mic-active-bar.svg?style=for-the-badge
[license-url]: https://github.com/david-s-svedberg/mic-active-bar/blob/master/LICENSE.txt