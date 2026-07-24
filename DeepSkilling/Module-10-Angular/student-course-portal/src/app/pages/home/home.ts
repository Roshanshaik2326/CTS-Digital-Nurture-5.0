import {
  Component,
  OnInit,
  OnChanges,
  OnDestroy,
  SimpleChanges
} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, FormsModule, CourseCard],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnChanges, OnDestroy {

  portalName = 'Student Course Portal';

  isPortalActive = true;

  message = '';

  searchTerm = '';

  today = new Date();

  selectedCourse = 'Angular Fundamentals';

  courses = [
    {
      id: 1,
      name: 'Angular Fundamentals',
      credits: 4,
      fee: 3500,
      available: true
    },
    {
      id: 2,
      name: 'React Basics',
      credits: 3,
      fee: 2800,
      available: true
    },
    {
      id: 3,
      name: 'Node.js',
      credits: 4,
      fee: 4200,
      available: false
    }
  ];

  constructor() {
    console.log('Constructor');
  }

  ngOnInit() {
    console.log('ngOnInit');
  }

  ngOnChanges(changes: SimpleChanges) {
    console.log(changes);
  }

  ngOnDestroy() {
    console.log('Destroyed');
  }

  onEnrollClick() {
    this.message = 'Enrollment opened!';
  }

  onCourseEnroll() {
    alert('Successfully enrolled!');
  }
}