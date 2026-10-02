# Deus Ex Randomizer

## Pack metadata
- **Game display name:** Deus Ex Randomizer
- **Crowd Control game ID:** `DeusEx`
- **Connector type:** `SimpleTCPServerConnector`


This directory contains the Crowd Control pack side of the **Deus Ex
Randomizer** integration. It is not a standalone Deus Ex mod or installer.
The game-side integration belongs to the Deus Ex Randomizer project:

<https://github.com/Die4Ever/deus-ex-randomizer>

## Requirements

- Crowd Control with the **Deus Ex Randomizer** pack selected.
- A compatible game-side integration from the Deus Ex Randomizer project.

## Setup

1. Install and configure the game-side integration using the instructions in
   the Deus Ex Randomizer project.
2. Start a Crowd Control session with this pack.
3. Launch or enable the game-side integration so it can connect to Crowd
   Control.

## Connection behavior

The pack is a legacy Simple TCP server. It listens on port `43384` on
`0.0.0.0` and expects the game-side component to connect and exchange the
legacy Crowd Control message format.

## Troubleshooting

- **No connection:** confirm that the game-side integration is installed and
  running, then check that another program is not already using port `43384`.
- **Effects are unavailable:** this repository does not contain the game-side
  setup or behavior. Consult the linked Deus Ex Randomizer project for its
  installation and compatibility requirements.

## Repository layout

- `DeusEx.cs` defines the pack.
