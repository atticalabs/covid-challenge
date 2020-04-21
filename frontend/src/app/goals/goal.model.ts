import { IonDatetime } from '@ionic/angular';

export class Goal {

    public id: string; //TODO: string?
    public title: string;
    public description: string;
    public imagePath: string;
    public date: IonDatetime;

    constructor(id: string, title: string, description: string,
        imagePath: string, date: IonDatetime){

            this.id = id;
            this.title = title;
            this.description = description;
            this.imagePath = imagePath;
            this.date = date;
    }
}