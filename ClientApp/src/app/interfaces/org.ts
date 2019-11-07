export interface Org {
    id: number;
    sourcedId: string;
    status: string;
    dateLastModified: Date;
    name: string;
    type: string;
    identifier: string;
    classification: string;
    gender: string;
    boarding: boolean;
    parentSourcedId: string;
}
