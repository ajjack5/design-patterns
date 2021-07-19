export interface CloneableObject {
    data: number;
    otherData: number;
}

// example
export class PrototypeUsage {

    constructor() { }

    public someFunction(): void {
        const originalObject: CloneableObject = <CloneableObject>{ data: 42, otherData: 99 };

        // easiest way to deep-copy clone in TypeScript
        // no need for added complexities of design pattern unless additional logic is provided in clone constructors
        const clone: CloneableObject = JSON.parse(JSON.stringify(originalObject));

        // do
    }
}

// other examples include how typescript compiles into javascript - class functions become prototypes