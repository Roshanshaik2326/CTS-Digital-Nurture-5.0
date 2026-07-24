import {
  Component,
  OnInit,
  OnChanges,
  OnDestroy,
  SimpleChanges
} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, CourseCard],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnChanges, OnDestroy {

  portalName = 'Student Course Portal';
  isPortalActive = true;
  message = '';
  searchTerm = '';

  selectedCourse = 'Angular Fundamentals';

  constructor() {
    console.log('Constructor called');
  }

  ngOnInit(): void {
    console.log('ngOnInit executed');
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('ngOnChanges', changes);
  }

  ngOnDestroy(): void {
    console.log('ngOnDestroy executed');
  }

  onEnrollClick(): void {
    this.message = 'Enrollment opened!';
  }

  onCourseEnroll(): void {
    alert('Successfully enrolled in ' + this.selectedCourse);
  }
}