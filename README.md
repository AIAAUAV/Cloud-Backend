Cloud Backend
====================

Mediates all communication between the [UAV](https://github.com/AUUAV/MainUAV) and the [base station](https://github.com/AUUAV/Base-Station), and acts as telemetry and data log for all flights made with the [UAV](https://github.com/AUUAV/MainUAV).

Spec
---------------------

* Receive live telemetry from [UAV](https://github.com/AUUAV/MainUAV)
* Receive logged telemetry from [UAV](https://github.com/AUUAV/MainUAV) if connection lost for any period of time
* Log telemetry from [UAV](https://github.com/AUUAV/MainUAV) into a database
* Send relevent telemetry/logs to any authenticated clients requesting them
* Forward instructions from authenticated client (ie the [Base-Station](https://github.com/AUUAV/Base-Station)) to the [UAV](https://github.com/AUUAV/MainUAV) and log them
* Forward live stream of camera from [UAV](https://github.com/AUUAV/MainUAV) to public endpoint (youtube, twitch, other?)

Notes
--------------------

Connection to clients will be authenticated by Slack, and checking if they are on the team set in a config (this allows this project to remain open source).
The connection to the [UAV](https://github.com/AUUAV/MainUAV) will also need to be authenticated initially somehow, perhaps using a hardware ID or network ID?
Initially the only client will be the [base station](https://github.com/AUUAV/Base-Station) (only one can be connected in control mode at at time) but also looking into bot connector for logs and telemetry directly in slack.
