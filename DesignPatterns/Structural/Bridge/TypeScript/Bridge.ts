export interface IElectronicDevice {
    powerOn: boolean;
    enabled: boolean;
    volume: number;
    channel: number;
}

export interface ITV extends IElectronicDevice {
    screenSize: number;
}

export interface IRadio extends IElectronicDevice {
    frequency: number;
}

export class RemoteController {
    constructor(protected _electronicDevice: IElectronicDevice) { }

    public togglePower(): void {
        this._electronicDevice.powerOn = !this._electronicDevice.powerOn;
    }

    public volumeUp(): void {
        this._electronicDevice.volume++;
    }

    public volumeDown(): void {
        this._electronicDevice.volume--;
    }

    public channelUp(): void {
        this._electronicDevice.channel++;
    }

    public channelDown(): void {
        this._electronicDevice.channel--;
    }
}

export class AdvancedRemoteController extends RemoteController {
    constructor(electronicDevice: IElectronicDevice) {
        super(electronicDevice)
    }

    public mute(): void {
        this._electronicDevice.volume = 0;
    }

    public openNetflixChannel(): void {
        this._electronicDevice.channel = 42;
    }

    public Snooze(): void {
        setTimeout(() => {
            this._electronicDevice.powerOn = false;
        }, 3000);
    }
}

// example
// bridging behaviour from one object to another
export class SomeService {
    public electronicDevice: IElectronicDevice | undefined;
    public remote: AdvancedRemoteController | undefined;

    constructor() {
        this.electronicDevice = <ITV>{ powerOn: true, enabled: true, volume: 12, channel: 42, screenSize: 4000 };
        this.remote = new AdvancedRemoteController(this.electronicDevice);
    }

    public doSomething(): void {
        this.remote.togglePower();

        // do
    }
}