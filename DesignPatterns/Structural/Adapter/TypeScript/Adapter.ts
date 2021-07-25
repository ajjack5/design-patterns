export interface IJapanesePowerPlug {
    numConductorProngs: number;
    dcVoltage: number;
    damaged: boolean;
}

export interface IAustralianPowerPlug {
    numMetalProngs: number;
    dcVoltage: number;
    damaged: boolean;
}

export class AustralianPowerPoint {
    public safetyTurnedOn: boolean = true;

    constructor() { }

    public acceptAustralianPlug(plug: IAustralianPowerPlug): boolean {
        if (this.safetyTurnedOn && !plug.damaged) {
            return true;
        }
        return false;
    }
}

export class JapaneseToAustralianPowerPointAdapter extends AustralianPowerPoint {
    private _powerConverter: PowerConverter;

    constructor(powerConverter: PowerConverter)  {
        super();
        this._powerConverter = powerConverter;
    }

    public acceptJapanesePlug(plug: IJapanesePowerPlug): boolean {
        const australianPowerPlug = this._powerConverter.convertJapanesePlugIntoAustralianPlug(plug);
        return this.acceptAustralianPlug(australianPowerPlug);
    }
}

export class PowerConverter {
    public convertJapanesePlugIntoAustralianPlug(japanesePowerPlug: IJapanesePowerPlug): IAustralianPowerPlug  {
        const australianPowerPlug = <IAustralianPowerPlug>{ };

        australianPowerPlug.dcVoltage = Math.min(australianPowerPlug.dcVoltage, japanesePowerPlug.dcVoltage);
        australianPowerPlug.damaged = japanesePowerPlug.damaged;

        return australianPowerPlug;
    }
}


// example
export class SomeService {
    public australianPowerPoint: AustralianPowerPoint | undefined;
    public australianPowerPointAdapter: JapaneseToAustralianPowerPointAdapter | undefined;

    constructor() {
        this.australianPowerPoint = new AustralianPowerPoint();
        this.australianPowerPointAdapter = new JapaneseToAustralianPowerPointAdapter(new PowerConverter());
    }

    public plugAustralianCordIntoAustralianPowerPoint(): void {
        const powerPlug: IAustralianPowerPlug = <IAustralianPowerPlug>{ damaged: false, dcVoltage: 240, numMetalProngs: 3 };
        const result = this.australianPowerPoint.acceptAustralianPlug(powerPlug);

        // do
    }

    public plugJapaneseCordIntoAustralianPowerPoint(): void {
        const powerPlug: IJapanesePowerPlug = <IJapanesePowerPlug>{ damaged: false, dcVoltage: 280, numConductorProngs: 2 };
        const result = this.australianPowerPointAdapter.acceptJapanesePlug(powerPlug); // adapter

        // do
    }
}