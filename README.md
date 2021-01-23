# Impostor-Server

[![Discord](https://img.shields.io/badge/Discord-chat-blue?style=for-the-badge)](https://discord.gg/pM7YxX7tZF)
[![AppVeyor](https://img.shields.io/appveyor/build/xIgreq/impostor-server?style=for-the-badge)](https://ci.appveyor.com/project/xIgreq/impostor-server/branch/dev)

Impostor-Server is public fork of official [Impostor Server Software](https://github.com/Impostor/Impostor), written in C#. 

We support Steam, Itch, Android and iOS. The latest version supported is `2020.9.07`, the `dev` build currently supports `2020.12.05`.

| Impostor version | Among Us version | Experimental | Download |
|-|-|-|-|
| 1.1.0 | 2020.09.07 - 2020.09.22 | No | [![Download](https://img.shields.io/badge/Download-v1.1.0-blue?style=flat-square)](https://github.com/Impostors-ga/Impostor-Server/releases/tag/v1.1.0) |
| 1.4.20 | 2020.09.07 - 2020.12.05 | No | [![Download](https://img.shields.io/badge/Download-v1.4.20-green?style=flat-square)](https://github.com/Impostors-ga/Impostor-Server/releases/tag/v1.4.20) |

## Features

- All Among Us features are implemented. It is a full replacement for the official server.
- Plugin support.
- Server-sided anticheat.

## Installation

### Client

If you just want to play on a server hosted by someone else, you need to follow these instructions.

#### Windows

Follow the instructions in [this website](https://impostors-ga.github.io/Impostor-Server)

#### Android

##### Android 10 and below.
1. Go to [this website](https://impostors-ga.github.io/Impostor-Server) **(ON YOUR MOBILE DEVICE)**
2. Follow the instructions listed there.

##### Android 11.
1. Connect your phone to a computer. Go to [this website](https://impostors-ga.github.io/Impostor-Server) on the computer and follow the steps 1 and 2 to generate a `regionInfo.dat` file.
2. Instead of following the next steps, open the phone's internal storage on your computer and navigate to `/sdcard/Android/data/com.innersloth.spacemafia/files`.
3. Copy the generated `regionInfo.dat` file into the `files` folder you just navigated to.

#### iOS

iOS devices need to be jailbroken in order to connect to Impostor servers. 

### Server

See the [docs](docs/Running-the-server.md) for instructions on how to set it up.

## Troubleshooting

See [TROUBLESHOOTING](docs/TROUBLESHOOTING.md) to solve issues the Impostor client or the server.

## Contributing

See [CONTRIBUTING](CONTRIBUTING.md).

## License

This software is distributed under the **GNU GPLv3** License.

## Credits

- [willardf/Hazel-Networking](https://github.com/willardf/Hazel-Networking)
- [Impostor/Impostor](https://github.com/Impostor/Impostor)
