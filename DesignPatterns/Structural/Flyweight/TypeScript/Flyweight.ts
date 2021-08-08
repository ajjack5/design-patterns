export class CommonStaticImage {
    public readonly imageData: number[];
    // mark as immutable

    constructor() {
        this.imageData = [];
        // sets the static image data once
    }
}

export class FlyweightObject {
    public XPos: number | undefined;
    public YPos: number | undefined;

    public get CommonStaticImageData(): number[] {
        return this._commonStaticImage.imageData;
    };

    // immutable common flyweight data
    private readonly _commonStaticImage: CommonStaticImage | undefined;

    constructor(commonStaticImage: CommonStaticImage)
    {
        this._commonStaticImage = commonStaticImage;
    }
}

// example
export class SomeService {
    public readonly commonStaticImage: CommonStaticImage = new CommonStaticImage();
    public flyweight1: FlyweightObject | undefined;
    public flyweight2: FlyweightObject | undefined;

    constructor() {
        this.flyweight1 = new FlyweightObject(this.commonStaticImage);
        this.flyweight2 = new FlyweightObject(this.commonStaticImage);
    }
}