export class Singleton {
    private static _instance: Singleton | null = null;

    private constructor() { }

    public static getInstance(): Singleton {
        if (this._instance == null) {
            this._instance = new this();
        }

        return this._instance;
    }
}

// example
export class SingletonUsage {

    constructor() { }

    public someFunction(): void {
        const x: Singleton = Singleton.getInstance();

        // do whatever
    }
}